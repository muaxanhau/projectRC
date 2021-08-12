import styled, { css } from 'styled-components'

export const Table = styled.table`
  --font-size: calc(var(--font-size-medium) * 0.8);
  --height-default: 350px;
  --width-default: 300px;
  --header-height: 35px;
  --border: 1px solid var(--color-9-8);
  --padding-box: calc(var(--padding) / 2);
  --border-collapse: collapse;
  border-collapse: var(--border-collapse);
  width: ${({ width }) => width ?? 'var(--width-default)'};
  height: ${({ height }) => height ?? 'var(--height-default)'};
  font-size: var(--font-size);

  & * {
    border-collapse: var(--border-collapse);
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
  width: calc(100% - var(--scrollbar-width));
  height: var(--header-height);
  background-color: var(--color-8-9);
  border: var(--border);

  & *:not(:last-child) {
    border-right: var(--border);
  }

  & > tr {
    height: 100%;
  }
`
export const ColumnTitle = styled.th`
  font-family: var(--font-family-2);
  color: var(--color-2-5);
  word-break: break-all;
`
export const Column = styled.td`
  color: var(--color-9-7);
  padding: var(--padding-box);
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
        background-color: var(--color-2-3);

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
  height: calc(100% - var(--header-height));
  background-color: var(--color-6-10);
  border-left: var(--border);
  border-bottom: var(--border);
  display: block;
  overflow-y: scroll;
  overflow-x: hidden;

  & > ${Row} {
    border-bottom: var(--border);

    &:nth-child(even) {
      background-color: var(--color-7-11);
    }

    &:nth-child(odd) {
      background-color: var(--color-6-10);
    }

    & > ${Column} {
      border-right: var(--border);
    }
  }
`
export const SortIcon = styled.img`
  width: var(--font-size);
  aspect-ratio: 1;
  object-fit: cover;
  margin-left: calc(var(--font-size) / 4);
`
export const Input = styled.input`
  font-size: inherit;
  width: 100%;
  color: var(--color-9-8);
  background-color: transparent;
  border: none;

  &:focus {
    outline: none;
  }
`
