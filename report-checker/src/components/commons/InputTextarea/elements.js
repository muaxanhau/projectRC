import styled from 'styled-components'

export const Textarea = styled.textarea`
  resize: none;
  font-family: 'Segoe UI';
  width: ${({ width }) => (width ? width : '100px')};
  height: ${({ height }) => (height ? height : '170px')};
  padding: calc(var(--padding) / 2);

  &:focus {
    outline: none;
    border-color: var(--color-1);
  }
`
