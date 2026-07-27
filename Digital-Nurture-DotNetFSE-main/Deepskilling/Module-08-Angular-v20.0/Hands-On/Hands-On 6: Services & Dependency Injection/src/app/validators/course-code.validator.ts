import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

export function courseCodeValidator(): ValidatorFn {
  return (control: AbstractControl): ValidationErrors | null => {
    const value = control.value;
    if (!value) {
      return null; // Don't validate empty values, let Validators.required handle it
    }
    const regex = /^[a-zA-Z]{2,4}\d{3}$/;
    const valid = regex.test(value);
    return valid ? null : { invalidCourseCode: true };
  };
}
