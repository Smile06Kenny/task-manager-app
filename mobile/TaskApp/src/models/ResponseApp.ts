export interface ResponseApp<T> {
  statusCode: number;
  message: string;
  data: T;
}