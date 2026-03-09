import React, { useEffect, useState } from 'react';
import { View, Text, StyleSheet } from 'react-native';
import { getTaskById } from '../services/taskService';
import { Task } from '../models/Task';


type Props = {
  route: {
    params: {
      id: number;
    };
  };
};

export default function TaskDetailScreen({ route }: Props) {

  const { id } = route.params;

  const [task, setTask] = useState<Task | null>(null);

  useEffect(() => {
    loadTask();
  }, []);

  const loadTask = async () => {
    const data = await getTaskById(id);
    setTask(data);
  };

  if (!task) return <Text>Cargando...</Text>;

  return (
    <View style={styles.container}>
      <Text style={styles.title}>{task.title}</Text>

      <Text style={styles.label}>Descripción</Text>
      <Text>{task.description}</Text>

      <Text style={styles.label}>Prioridad</Text>
      <Text>{task.priority}</Text>

      <Text style={styles.label}>Estado</Text>
      <Text>{task.status}</Text>
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    padding: 20,
    backgroundColor: '#fff'
  },

  title: {
    fontSize: 24,
    fontWeight: 'bold',
    marginBottom: 20
  },

  label: {
    marginTop: 15,
    fontWeight: 'bold'
  }
});