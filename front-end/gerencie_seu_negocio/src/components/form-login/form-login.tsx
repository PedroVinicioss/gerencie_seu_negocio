export default function FormLogin() {
  return (
    <div className="w-1/2 bg-white text-black flex flex-col justify-center items-center p-8">
    <h2 className="text-4xl font-bold">Faça seu login</h2>
    <button className="mt-4 w-[4vh] h-[4vh] border rounded-full">G+</button>
    <p className="mt-2 text-gray-600">
      ou use seu e-mail e senha para se autenticar:
    </p>

    <div className="w-full max-w-[300px] space-y-4 mt-4">
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
      Entrar
    </button>
  </div>
  );
}
