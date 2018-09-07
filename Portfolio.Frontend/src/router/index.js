import Vue from 'vue'
import Router from 'vue-router'
import NavigationNerija from '@/components/Navigation/NavigationNerija'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '*',
      name: 'NavigationNerija',
      component: NavigationNerija
    }
  ]
})
