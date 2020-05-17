// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import VueAnalytics from 'vue-analytics'
import Project from './Apps/Project'
import ProjectListApp from './Apps/ProjectListApp'

//font-awesome icons
import { library } from '@fortawesome/fontawesome-svg-core'
import { faUsersCog, faCode, faShoppingCart, faChevronCircleDown, faChevronCircleUp  } from '@fortawesome/free-solid-svg-icons'
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'

Vue.use(VueAnalytics, {
  id: 'UA-143407872-1'
})

library.add([faUsersCog, faCode, faShoppingCart, faChevronCircleDown, faChevronCircleUp])

Vue.component('font-awesome-icon', FontAwesomeIcon)
Vue.component("Project", Project)
Vue.component("ProjectList", ProjectListApp)
// Vue.component("Uanimate", Uanimate)

Vue.config.productionTip = false


if(document.getElementById("project")){
  new Vue({
    el: '#project',
    template: '<Project/>',
    components: { Project }
  })
}
 
if(document.getElementById("projects")){
    new Vue({
      el: '#projects',
      template: '<ProjectListApp/>',
      components: { ProjectListApp }
  })
}
