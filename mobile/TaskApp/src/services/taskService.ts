import { apiClient } from '../api/apiClient';
import { Task } from '../models/Task';
import { ResponseApp } from '../models/ResponseApp';

export const getTasks = async (
  status?: string,
  priority?: string
): Promise<Task[]> => {
  try {
    const response = await apiClient.get<ResponseApp<Task[]>>('/tasks', {
      params: {
        status,
        priority
      }
    });
    return response.data.data;
  } catch (error) {
    console.error('Error loading tasks', error);
    throw error;
  }
};

export const getTaskById = async (id: number): Promise<Task> => {
  try {
    const response = await apiClient.get<ResponseApp<Task>>(`/tasks/${id}`);
    return response.data.data;
  } catch (error) {
    console.error('Error loading task', error);
    throw error;
  }
};