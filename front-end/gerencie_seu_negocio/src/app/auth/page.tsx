"use client";
import FormLogin from "@/components/FormLogin/form-login";
import FormRegister from "@/components/FormRegister/form-register";
import { useState } from "react";

export default function AuthPage() {
  const [isLogin, setIsLogin] = useState(true);

  return (
    <div className="flex justify-center items-center h-screen bg-gray-300">
      <div className="relative w-[90%] max-w-[1257px] h-[90%] max-h-[768px] flex rounded-[25px] overflow-hidden shadow-lg bg-white">
        <div className={`absolute inset-0 flex transition-transform duration-500 ease-in-out ${isLogin ? "translate-x-0" : "-translate-x-1/2"}`}> 
          {isLogin ? <FormLogin /> : <FormRegister />}
          {!isLogin ? <FormLogin /> : <FormRegister />}
        </div>

        <div className={`absolute inset-y-0 left-0 w-1/2 flex items-center justify-center transition-transform duration-500 ease-in-out ${isLogin ? "translate-x-0" : "translate-x-full"} bg-black text-white`}>
          {!isLogin ? (
            <div className="text-center">
              <h1 className="text-3xl font-bold">Não possui uma conta?</h1>
              <p className="mt-2">Crie sua conta agora para dominar seus negócios!</p>
              <button onClick={() => setIsLogin(true)} className="mt-6 px-6 py-2 border border-white rounded-full">
                Registre-se
              </button>
            </div>
          ) : (
            <div className="text-center">
              <h1 className="text-3xl font-bold">Bem vindo de volta!</h1>
              <p className="mt-2">Faça o login para administrar seu negócio</p>
              <button onClick={() => setIsLogin(false)} className="mt-6 px-6 py-2 border border-white rounded-full">
                Login
              </button>
            </div>
          )}
        </div>
      </div>
    </div>
  );
}
