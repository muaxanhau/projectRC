import { all } from 'redux-saga/effects'
import dataCollectionSaga from './../features/DataCollection/dataCollectionSaga'

function * rootSaga () {
  yield all([dataCollectionSaga()])
}

export default rootSaga
