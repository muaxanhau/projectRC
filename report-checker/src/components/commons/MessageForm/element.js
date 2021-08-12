import styled, { css } from 'styled-components'

export const Container = styled.div`
  --width-default: 200px;
  width: ${({ width }) => width ?? 'var(--width-default)'};
`
export const InfoArea = styled.div`
  display: flex;
  gap: var(--gap-1);
  font-family: var(--font-family-2);

  ${({ position }) =>
    position === 'right' &&
    css`
      flex-direction: row-reverse;
      text-align: right;
    `}
`
export const Info = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: center;

  & > h4 {
    color: var(--color-2-5);
  }

  & > p {
    color: var(--color-2-8);
    font-size: 80%;
  }
`
export const ContentArea = styled.div`
  padding: 0 ${({ padding }) => padding};
`
