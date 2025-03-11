const API_URL = process.env.NEXT_PUBLIC_API_URL || "https://suaapi.com/auth";

export interface AuthResponse {
  token: string;
}

export const loginUser = async (email: string, password: string): Promise<AuthResponse> => {
  const response = await fetch(`${API_URL}/login`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ email, password }),
  });

  if (!response.ok) {
    throw new Error("Erro ao autenticar");
  }

  return response.json();
};

export const registerUser = async (name: string, email: string, password: string): Promise<void> => {
  const response = await fetch(`${API_URL}/register`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ name, email, password }),
  });

  if (!response.ok) {
    throw new Error("Erro ao cadastrar");
  }
};
