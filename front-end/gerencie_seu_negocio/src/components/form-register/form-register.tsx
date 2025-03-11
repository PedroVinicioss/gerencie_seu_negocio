export default function FormRegister() {
  return (
    <div className="w-1/2 bg-white text-black flex flex-col justify-center items-center p-8">
      <h2 className="text-4xl font-bold">Cadastre-se</h2>
      <button className="mt-4 w-[4vh] h-[4vh] border rounded-full">G+</button>
      <p className="mt-2 text-gray-600">
        ou use suas informações para o cadastro:
      </p>

      <div className="w-full max-w-[300px] space-y-4 mt-4">
        <input
          className="w-full p-3 border rounded-md"
          type="text"
          placeholder="Nome"
        />
        <input
          className="w-full p-3 border rounded-md"
          type="email"
          placeholder="E-mail"
        />
        <input
          className="w-full p-3 border rounded-md"
          type="password"
          placeholder="Senha"
        />
      </div>

      <button className="mt-6 px-10 py-2 bg-black text-white rounded-full">
        Registre-se
      </button>
    </div>
  );
}
