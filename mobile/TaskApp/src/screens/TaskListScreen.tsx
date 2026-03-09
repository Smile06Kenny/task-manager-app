import React, { useEffect, useState } from 'react';
import {
  View,
  Text,
  FlatList,
  StyleSheet,
  TouchableOpacity,
  Pressable,
  ActivityIndicator
} from 'react-native';

import { getTasks } from '../services/taskService';
import { Task } from '../models/Task';

type Props = {
  navigation: any;
};

export default function TaskListScreen({ navigation }: Props) {

  const [tasks, setTasks] = useState<Task[]>([]);
  const [loading, setLoading] = useState(false);

  const [statusFilter, setStatusFilter] = useState<string | undefined>();
  const [priorityFilter, setPriorityFilter] = useState<string | undefined>();

  useEffect(() => {
    loadTasks();
  }, [statusFilter, priorityFilter]);

  const loadTasks = async () => {
    try {
      setLoading(true);
      const data = await getTasks(statusFilter, priorityFilter);
      setTasks(data);
    } finally {
      setLoading(false);
    }
  };

  const getPriorityColor = (priority: string) => {
    switch (priority) {
      case 'HIGH':
        return '#ff4d4f';
      case 'MEDIUM':
        return '#faad14';
      case 'LOW':
        return '#52c41a';
      default:
        return '#ccc';
    }
  };

  const renderItem = ({ item }: { item: Task }) => (
    <TouchableOpacity
      style={styles.card}
      onPress={() =>
        navigation.navigate('TaskDetail', { id: item.id })
      }
    >
      <View
        style={[
          styles.priorityIndicator,
          { backgroundColor: getPriorityColor(item.priority) }
        ]}
      />

      <View style={styles.content}>
        <Text style={styles.title}>{item.title}</Text>

        <Text style={styles.description}>
          {item.description}
        </Text>

        <View style={styles.footer}>
          <Text style={styles.priority}>
            {item.priority}
          </Text>

          <Text style={styles.status}>
            {item.status}
          </Text>
        </View>
      </View>
    </TouchableOpacity>
  );

  return (
    <View style={styles.container}>

      <Text style={styles.header}>Task Manager</Text>

      {/* FILTERS */}

      <View style={styles.filters}>

        <Text style={styles.filterTitle}>Priority</Text>

        <View style={styles.filterRow}>

          <Pressable onPress={() => setPriorityFilter(undefined)}>
            <Text
              style={[
                styles.filter,
                priorityFilter === undefined && styles.filterActive
              ]}
            >
              All
            </Text>
          </Pressable>

          <Pressable onPress={() => setPriorityFilter("HIGH")}>
            <Text
              style={[
                styles.filter,
                priorityFilter === "HIGH" && styles.filterActive
              ]}
            >
              High
            </Text>
          </Pressable>

          <Pressable onPress={() => setPriorityFilter("MEDIUM")}>
            <Text
              style={[
                styles.filter,
                priorityFilter === "MEDIUM" && styles.filterActive
              ]}
            >
              Medium
            </Text>
          </Pressable>

          <Pressable onPress={() => setPriorityFilter("LOW")}>
            <Text
              style={[
                styles.filter,
                priorityFilter === "LOW" && styles.filterActive
              ]}
            >
              Low
            </Text>
          </Pressable>

        </View>

        <Text style={styles.filterTitle}>Status</Text>

        <View style={styles.filterRow}>

          <Pressable onPress={() => setStatusFilter(undefined)}>
            <Text
              style={[
                styles.filter,
                statusFilter === undefined && styles.filterActive
              ]}
            >
              All
            </Text>
          </Pressable>

          <Pressable onPress={() => setStatusFilter("PENDING")}>
            <Text
              style={[
                styles.filter,
                statusFilter === "PENDING" && styles.filterActive
              ]}
            >
              Pending
            </Text>
          </Pressable>

          <Pressable onPress={() => setStatusFilter("IN_PROGRESS")}>
            <Text
              style={[
                styles.filter,
                statusFilter === "IN_PROGRESS" && styles.filterActive
              ]}
            >
              In Progress
            </Text>
          </Pressable>

          <Pressable onPress={() => setStatusFilter("DONE")}>
            <Text
              style={[
                styles.filter,
                statusFilter === "DONE" && styles.filterActive
              ]}
            >
              Done
            </Text>
          </Pressable>

        </View>

      </View>

      {loading ? (
        <ActivityIndicator size="large" />
      ) : (
        <FlatList
          data={tasks}
          keyExtractor={(item) => item.id.toString()}
          renderItem={renderItem}
        />
      )}

    </View>
  );
}

const styles = StyleSheet.create({

  container: {
    flex: 1,
    backgroundColor: '#f4f6f8',
    padding: 16
  },

  header: {
    fontSize: 26,
    fontWeight: 'bold',
    marginBottom: 16,
    marginTop: 40
  },

  filters: {
    marginBottom: 15
  },

  filterTitle: {
    fontWeight: "bold",
    marginBottom: 5
  },

  filterRow: {
    flexDirection: "row",
    justifyContent: "space-between",
    marginBottom: 10
  },

  filter: {
    paddingHorizontal: 12,
    paddingVertical: 6,
    backgroundColor: "#e5e5e5",
    borderRadius: 20
  },

  filterActive: {
    backgroundColor: "#1677ff",
    color: "#fff"
  },

  card: {
    flexDirection: 'row',
    backgroundColor: '#fff',
    borderRadius: 10,
    marginBottom: 12,
    shadowColor: '#000',
    shadowOpacity: 0.1,
    shadowRadius: 4,
    elevation: 3
  },

  priorityIndicator: {
    width: 6,
    borderTopLeftRadius: 10,
    borderBottomLeftRadius: 10
  },

  content: {
    flex: 1,
    padding: 12
  },

  title: {
    fontSize: 18,
    fontWeight: '600'
  },

  description: {
    color: '#666',
    marginTop: 4
  },

  footer: {
    flexDirection: 'row',
    justifyContent: 'space-between',
    marginTop: 10
  },

  priority: {
    fontWeight: '600'
  },

  status: {
    color: '#555'
  }

});