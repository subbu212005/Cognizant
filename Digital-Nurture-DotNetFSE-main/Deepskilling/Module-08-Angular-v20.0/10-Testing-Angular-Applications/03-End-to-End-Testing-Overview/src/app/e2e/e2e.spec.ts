import { test, expect } from '@playwright/test';

test('home page', async ({ page })=>{
 await page.goto('http://localhost:4200');
 await expect(page.locator('h1')).toHaveText('End-to-End Testing Overview');
});
