import axios from 'axios';


const tmdbApi = axios.create({
  baseURL: 'http://localhost:5267/',
  params: {
    // api_key: apiKey,
  },
});

tmdbApi.interceptors.request.use((config) => {
  const token = localStorage.getItem('authToken');
  if (token) {
    config.headers['Authorization'] = `Bearer ${token}`;
  }
  return config;
});


export default tmdbApi;
