import React, { useState, useEffect } from 'react';

const AuthPage = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [isLoading, setIsLoading] = useState(false);
  const [isLogin, setIsLogin] = useState(true);

  useEffect(() => {
    // Example: Fetch some initial data if needed when the component mounts
    async function loadInitialData() {
      // Fetch initial data if needed, for example, checking if the user is already authenticated
      // const authData = await fetchAuthStatus();
      // Handle the fetched data
    }
    loadInitialData();
  }, []); // Empty dependency array ensures this runs only once when the component mounts

  const handleAuth = async () => {
    setIsLoading(true);
    try {
      const endpoint = isLogin ? '/Auth/Login' : '/Auth/SignUp';
      const response = await fetch(endpoint, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify({ email, password }),
      });

      const data = await response.json();
      console.log(data); // Handle the response from the server
    } catch (error) {
      console.error('Error:', error);
    } finally {
      setIsLoading(false);
    }
  };

  const toggleAuthMode = () => {
    setIsLogin(!isLogin);
  };

  return (
    <div>
      <h2>{isLogin ? 'Login' : 'Sign Up'}</h2>
      <div>
        <input
          type="email"
          placeholder="Email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
          required
        />
      </div>
      <div>
        <input
          type="password"
          placeholder="Password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
          required
        />
      </div>
      <div>
        <button onClick={handleAuth} disabled={isLoading}>
          {isLoading ? 'Loading...' : isLogin ? 'Login' : 'Sign Up'}
        </button>
      </div>
      <div>
        <button onClick={toggleAuthMode}>
          {isLogin ? 'Switch to Sign Up' : 'Switch to Login'}
        </button>
      </div>
    </div>
  );
};

export default AuthPage;
