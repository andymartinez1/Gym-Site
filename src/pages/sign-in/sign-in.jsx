export default function SignIn() {
  return (
    <div className="sign-in-container">
      <header className="sign-in-header">
        <h1>Sign In</h1>
        <p>Welcome back! Please sign in to your account.</p>
      </header>
      <section className="sign-in-form">
        <form>
          <label htmlFor="email">Email:</label>
          <input type="email" id="email" name="email" required />
          <label htmlFor="password">Password:</label>
          <input type="password" id="password" name="password" required />
          <button type="submit">Sign In</button>
        </form>
      </section>
      <footer className="sign-in-footer">
        <p>Don't have an account? Sign up now!</p>
      </footer>
    </div>
  );
}
