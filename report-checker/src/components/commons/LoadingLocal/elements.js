import styled from 'styled-components'

export const Container = styled.div`
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
`
export const Wrapper = styled.div`
  font-size: var(--font-size-meidum);
  font-family: var(--font-family-2);
  color: var(--color-4-5);

  animation: kf-loading 0.5s infinite alternate;
  @keyframes kf-loading {
    0% {
      opacity: 0;
    }
    100% {
      opacity: 0.8;
    }
  }
`
