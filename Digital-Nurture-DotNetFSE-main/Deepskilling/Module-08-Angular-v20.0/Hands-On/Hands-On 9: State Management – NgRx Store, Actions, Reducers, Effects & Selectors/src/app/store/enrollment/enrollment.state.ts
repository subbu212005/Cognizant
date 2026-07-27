export interface EnrollmentState {
  enrolledCourseIds: string[];
  loading: boolean;
  error: string | null;
}

export const initialEnrollmentState: EnrollmentState = {
  enrolledCourseIds: [],
  loading: false,
  error: null
};
