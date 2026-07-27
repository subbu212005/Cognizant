import { CreditLabelPipe } from './credit-label.pipe';

describe('CreditLabelPipe', () => {
  let pipe: CreditLabelPipe;

  beforeEach(() => {
    pipe = new CreditLabelPipe();
  });

  it('should create the pipe', () => {
    expect(pipe).toBeTruthy();
  });

  it('should format 1 credit as "1 Credit"', () => {
    expect(pipe.transform(1)).toBe('1 Credit');
  });

  it('should format multiple credits as "X Credits"', () => {
    expect(pipe.transform(3)).toBe('3 Credits');
    expect(pipe.transform(4)).toBe('4 Credits');
  });

  it('should format credits with custom suffix', () => {
    expect(pipe.transform(4, 'Elective')).toBe('4 Credits (Elective)');
  });

  it('should return empty string for null or undefined', () => {
    expect(pipe.transform(null)).toBe('');
    expect(pipe.transform(undefined)).toBe('');
  });
});
