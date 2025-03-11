"use client";
import { createContext, useContext, useState, useEffect } from "react";
import { loginUser } from "../services/authservice";
import Cookies from "js-cookie";

interface AuthContextType {
  user: string | null;
  login: (email: string, password: string) => Promise<void>;
  logout: () => void;
}

const AuthContext = createContext<AuthContextType | undefined>(undefined);

export const AuthProvider = ({ children }: { children: React.ReactNode }) => {
  const [user, setUser] = useState<string | null>(null);

  useEffect(() => {
    const token = Cookies.get("token");
    if (token) {
      setUser(token);
    }
  }, []);

  const login = async (email: string, password: string) => {
    const data = await loginUser(email, password);
    Cookies.set("token", data.token, { expires: 7 }); // Armazena o token por 7 dias
    setUser(data.token);
  };

  const logout = () => {
    Cookies.remove("token");
    setUser(null);
  };

  return <AuthContext.Provider value={{ user, login, logout }}>{children}</AuthContext.Provider>;
};

export const useAuth = () => {
  const context = useContext(AuthContext);
  if (!context) {
    throw new Error("useAuth deve ser usado dentro de um AuthProvider");
  }
  return context;
};
