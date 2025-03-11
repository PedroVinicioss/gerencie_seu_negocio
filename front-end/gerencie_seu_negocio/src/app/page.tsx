import Link from "next/link";

export default function Home() {
  return (
    <div>
      <h1>Page</h1>
      <Link href="/auth">
        login
      </Link>
    </div>
  );
}
