import { css } from 'styled-components'

export const Autofill = css`
  &:-webkit-autofill,
  &:-webkit-autofill:hover,
  &:-webkit-autofill:focus,
  &:-webkit-autofill:active {
    --autofill-background: 0 0 0 50px var(--background-color, #fff);
    box-shadow: var(--autofill-background) inset, var(--shadow);
  }

  &:-webkit-autofill {
    -webkit-text-fill-color: var(--text-color, #000);
  }
`
