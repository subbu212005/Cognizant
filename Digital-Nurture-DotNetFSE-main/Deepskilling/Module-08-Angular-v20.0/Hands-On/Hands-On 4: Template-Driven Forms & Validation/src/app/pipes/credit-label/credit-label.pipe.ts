import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'creditLabel',
  standalone: true
})
export class CreditLabelPipe implements PipeTransform {
  transform(value: number | undefined | null, suffix: string = ''): string {
    if (value === undefined || value === null) {
      return '';
    }
    const label = value === 1 ? 'Credit' : 'Credits';
    const extra = suffix ? ` (${suffix})` : '';
    return `${value} ${label}${extra}`;
  }
}
