import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom'; // Import useNavigate
import { loginUser, signUpUser } from "../controllers/userController";

const AuthPage = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [isLoading, setIsLoading] = useState(false);
  const [isLogin, setIsLogin] = useState(true);
  const [errorMessage, setErrorMessage] = useState('');
  const navigate = useNavigate(); 

  useEffect(() => {
    async function loadInitialData() {
      // Fetch initial data if needed
    }
    loadInitialData();
  }, []);

  const handleAuth = async () => {
    if(isLogin){
      setIsLoading(true);
      setErrorMessage('');
      try {
        const response = await loginUser(email, password);
        console.log(email,password)
        console.log(response);

        localStorage.setItem('authToken', response.tokens);
        localStorage.setItem('userEmail', response.email);
            
        console.log('Login successful:', response);

        navigate('/homepage');

      } catch (error) {
        setErrorMessage('Failed to authenticate. Please try again.');
        console.error('Error:', error);
      } finally {
        setIsLoading(false);
      }
    }
     if(!isLogin){
      setIsLoading(true);
      setErrorMessage(''); // Reset error message before starting the request
      try {
        const response = await signUpUser(email, password);
        console.log(response); // Handle the response from the server

        localStorage.setItem('authToken', response.tokens);
        localStorage.setItem('userEmail', response.email);
            
        console.log('signup successful:', response);

        navigate('/homepage');
      } catch (error) {
        setErrorMessage('Failed to authenticate. Please try again.');
        console.error('Error:', error);
      } finally {
        setIsLoading(false);
      }
    }
  
  };

  const toggleAuthMode = () => {
    setIsLogin(!isLogin);
  };

  return (
    <div className="flex flex-col items-center justify-center min-h-screen bg-gray-100">
      <div className="bg-white p-8 rounded shadow-md w-full max-w-md">
        <h2 className="text-2xl text-black font-semibold mb-6 text-center">
          {isLogin ? 'Login' : 'Sign Up'}
        </h2>
        <div className="mb-4">
          <input
            type="email"
            placeholder="Email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            required
            className="w-full p-3 text-black border rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
          />
        </div>
        <div className="mb-4">
          <input
            type="password"
            placeholder="Password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            required
            className="w-full p-3 text-black border rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
          />
        </div>
        
        {errorMessage && (
          <div className="mb-4 text-red-600">
            {errorMessage}
          </div>
        )}

        <div className="mb-6">
          <button
            onClick={handleAuth}
            disabled={isLoading}
            className="w-full p-3 bg-blue-500 text-white rounded hover:bg-blue-600 disabled:opacity-50"
          >
            {isLoading ? 'Loading...' : isLogin ? 'Login' : 'Sign Up'}
          </button>
        </div>
        <div className="text-center">
          <button
            onClick={toggleAuthMode}
            className="text-blue-500 hover:underline"
          >
            {isLogin ? 'Switch to Sign Up' : 'Switch to Login'}
          </button>
        </div>
      </div>
    </div>
  );
};

export default AuthPage;