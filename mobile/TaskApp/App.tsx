import React from 'react';
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

import TaskListScreen from './src/screens/TaskListScreen';
import TaskDetailScreen from './src/screens/TaskDetailScreen';

type RootStackParamList = {
  Tasks: undefined;
  TaskDetail: { id: number };
};

const Stack = createNativeStackNavigator<RootStackParamList>();

export default function App() {
  return (
    <NavigationContainer>
      <Stack.Navigator>

        <Stack.Screen
          name="Tasks"
          component={TaskListScreen}
        />

        <Stack.Screen
          name="TaskDetail"
          component={TaskDetailScreen}
        />

      </Stack.Navigator>
    </NavigationContainer>
  );
}