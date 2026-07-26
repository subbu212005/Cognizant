export interface Course {
  id: string;
  title: string;
  instructor: string;
  credits: number;
  category: string;
  description: string;
  progress: number;
  status: 'available' | 'enrolled' | 'completed';
  image: string;
}

export interface StudentProfile {
  name: string;
  email: string;
  studentId: string;
  major: string;
  gpa: number;
  avatar: string;
}
