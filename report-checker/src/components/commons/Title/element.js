import styled from 'styled-components'

const sizeArr = {
  small: 'var(--font-size-small)',
  medium: 'var(--font-size-medium)',
  large: 'var(--font-size-large)',
  get default () {
    return this.medium
  }
}
const typeArr = {
  dark: 'var(--color-2)',
  light: 'var(--color-7)',
  get default () {
    return this.dark
  }
}
export const Wrapper = styled.div`
  text-transform: uppercase;
  font-family: var(--font-family-2);
  font-weight: var(--font-bold);
  font-size: ${({ size }) => sizeArr[size] ?? sizeArr.default};
  color: ${({ type }) => typeArr[type] ?? typeArr.default};
  cursor: default;
`
