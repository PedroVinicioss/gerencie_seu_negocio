import { useState } from "react";
import { useAuth } from "@/context/AuthContext";
import { useRouter } from "next/navigation";

export default function FormLogin() {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState<string | null>(null);
  const { login } = useAuth();
  const router = useRouter();

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      await login(email, password);
      router.push("/dashboard");
    } catch (error) {
      setError("Email ou senha inválidos: " + error);
    }
  };

  return (
    <div className="w-1/2 bg-white text-black flex flex-col justify-center items-center p-8">
      <h2 className="text-4xl font-bold">Faça seu login</h2>
      <button className="mt-4 w-[4vh] h-[4vh] border rounded-full">G+</button>
      <p className="mt-2 text-gray-600">
        ou use seu e-mail e senha para se autenticar:
      </p>

      <form onSubmit={handleSubmit} className="w-full max-w-[300px] space-y-4 mt-4 flex flex-col justify-center items-center">
        <input
          className="w-full p-3 border rounded-md"
          type="email"
          placeholder="E-mail"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
          required
        />
        <input
          className="w-full p-3 border rounded-md"
          type="password"
          placeholder="Senha"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
          required
        />

        {error && <p className="text-red-500 text-center">{error}</p>}

        <button type="submit" className="mt-6 px-10 py-2 bg-black text-white rounded-full">
          Entrar
        </button>
      </form>
    </div>
  );
}
