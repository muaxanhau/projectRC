import styled, { css } from 'styled-components'

export const Table = styled.table`
  --height-default: 350px;
  --width-default: 300px;
  --border: 1px solid var(--color-9);
  --border-collapse: collapse;
  border-collapse: var(--border-collapse);
  width: ${({ width }) => width ?? 'var(--width-default)'};
  height: ${({ height }) => height ?? 'var(--height-default)'};
  text-align: center;

  & * {
    border-collapse: var(--border-collapse);
  }

  & > tbody {
    height: calc(${({ height }) => height ?? 'var(--height-default)'} - 35px);
    max-height: calc(
      ${({ height }) => height ?? 'var(--height-default)'} - 35px
    );
  }

  ${({ columnWidth }) =>
    columnWidth.map(
      (width, index) => css`
        & > * > * > *:nth-child(${index + 1}) {
          width: ${width};
        }
      `
    )};
`
export const Header = styled.thead`
  display: table;
  width: calc(100% - 17px);
  background-color: var(--color-8);
  border: var(--border);

  & *:not(:last-child) {
    border-right: var(--border);
  }
`
export const ColumnTitle = styled.th`
  color: var(--color-2);
  padding: 7px;
  word-break: break-all;
`
export const Column = styled.td`
  color: var(--color-9);
  padding: 5px;
  word-break: break-all;

  ${({ hasButton }) =>
    hasButton &&
    css`
      text-align: center !important;

      & > button {
        background-color: transparent !important;
        vertical-align: middle;
      }
    `}

  ${({ noneFocus }) =>
    !noneFocus &&
    css`
      &:focus-within {
        background-color: var(--color-2);

        & * {
          color: var(--color-5);
        }
      }
    `}
`
export const Row = styled.tr`
  display: table;
  width: 100%;

  & > ${Column}:not(:first-child) {
    text-align: left;
  }
`
export const Body = styled.tbody`
  background-color: var(--color-6);
  border-left: var(--border);
  border-bottom: var(--border);
  display: block;
  overflow-y: scroll;
  overflow-x: hidden;

  & > ${Row} {
    border-bottom: var(--border);

    &:nth-child(even) {
      background-color: var(--color-7);
    }

    &:nth-child(odd) {
      background-color: var(--color-6);
    }

    & > ${Column} {
      border-right: var(--border);
    }
  }
`
export const Input = styled.input`
  width: 100%;
  color: var(--color-9);
  background-color: transparent;
  border: none;

  &:focus {
    outline: none;
  }
`
