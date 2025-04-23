export default function SignUp() {
  return (
    <div className="sign-up-container">
      <header className="sign-up-header">
        <h1>Sign Up</h1>
        <p>Create a new account to get started!</p>
      </header>
      <section className="sign-up-form">
        <form>
          <label htmlFor="name">Name:</label>
          <input type="text" id="name" name="name" required />
          <label htmlFor="email">Email:</label>
          <input type="email" id="email" name="email" required />
          <label htmlFor="password">Password:</label>
          <input type="password" id="password" name="password" required />
          <button type="submit">Sign Up</button>
        </form>
      </section>
      <footer className="sign-up-footer">
        <p>Already have an account? Sign in now!</p>
      </footer>
    </div>
  );
}
