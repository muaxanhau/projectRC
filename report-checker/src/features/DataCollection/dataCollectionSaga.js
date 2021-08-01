import { all, fork, put, takeLeading } from 'redux-saga/effects'
import {
  setDefaultItemTotals,
  addDataToItemTotals,
  clearItemTotals,
  pushHistory
} from './dataCollectionSlice'

function * workPushHistory (action) {
  yield put(pushHistory())
}

function * watchActionForPushHistory (action) {
  yield takeLeading(
    [setDefaultItemTotals.type, addDataToItemTotals.type, clearItemTotals.type],
    workPushHistory
  )
}
function * dataCollectionSaga () {
  yield all([fork(watchActionForPushHistory)])
}

export default dataCollectionSaga
