import axios from 'axios';

export const apiClient = axios.create({
  baseURL: 'http://10.0.2.2:1048/api',
  timeout: 5000,
  headers: {
    'Content-Type': 'application/json'
  }
});