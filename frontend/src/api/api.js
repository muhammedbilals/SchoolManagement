import axios from 'axios';


const tmdbApi = axios.create({
  baseURL: 'http://localhost:5267/',
  params: {
    // api_key: apiKey,
  },
});

export default tmdbApi;
