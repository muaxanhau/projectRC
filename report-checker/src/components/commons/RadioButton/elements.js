import styled from 'styled-components'

export const Wrapper = styled.div`
  display: flex;
  width: ${({ width }) => width ?? 'fit-content'};
`
