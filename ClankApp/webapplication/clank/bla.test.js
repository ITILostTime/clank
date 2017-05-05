const bla = require('./bla');

test('run bla 4 times', () => {
  expect(bla("hey ", 4)).toBe("hey bla bla bla bla ");
});