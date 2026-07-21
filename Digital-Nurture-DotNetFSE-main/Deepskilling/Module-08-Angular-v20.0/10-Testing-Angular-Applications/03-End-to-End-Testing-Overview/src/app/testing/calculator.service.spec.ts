import { CalculatorService } from './calculator.service';

describe('CalculatorService',()=>{
 it('should add numbers',()=>{
  const s=new CalculatorService();
  expect(s.add(10,30)).toBe(40);
 });
});
