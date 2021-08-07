import { createSlice } from '@reduxjs/toolkit'

const initialState = {
  value: {
    isOpen: true
  },
  status: 'idle'
}

export const navbarSlice = createSlice({
  name: 'navbar',
  initialState,
  reducers: {
    resetState: state => {
      return initialState
    },
    toggleNavbar: state => {
      return {
        ...state,
        value: {
          isOpen: !state.value.isOpen
        }
      }
    }
  }
})

export const { resetState, toggleNavbar } = navbarSlice.actions

export const selectNavbar = state => state.navbar.value

export default navbarSlice.reducer
