import { createSlice } from '@reduxjs/toolkit'

const initialState = {
  value: {
    isLightTheme: true
  },

  status: 'idle'
}

export const themeSlice = createSlice({
  name: 'theme',
  initialState,
  reducers: {
    toggleTheme: state => {
      return {
        ...state,
        value: { ...state.value, isLightTheme: !state.value.isLightTheme }
      }
    }
  }
})

export const { toggleTheme } = themeSlice.actions

export const selectTheme = state => state.theme.value

export default themeSlice.reducer
