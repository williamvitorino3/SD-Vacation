<template>
  <app>
    <div class="container-fluid">
      <div class="row">
        <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
          <div class="form-group">
            <label for="anos">1° Número: </label>
            <input name="anos" type="number" class="form-control" v-model="num1">
          </div>
        </div>
      </div>
      <div class="row">
        <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
          <div class="form-group">
            <label for="">2° Número:</label>
            <input type="number" class="form-control" v-model="num2">
          </div>
        </div>
      </div>
      <div class="row">
        <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
          <div class="form-group">
          <button class="btn" @click="post">Calcular</button>
          </div>
        </div>
      </div>
      <p class="text-center" v-if="situacao.length">{{situacao}}</p>
    </div>
  </app>
</template>

<script>
import appMenu from './Menu.vue';
export default {
  components: {
    app: appMenu,
  },
  data () {
    return {
      num1: 0,
      num2: 0,
      situacao: '',
    }
  },
  methods: {
    post() {
      this.$http.post('http://localhost:5000/api/Numeros', [this.num1, this.num2]).then(
        success => {
          this.situacao = success.bodyText;
          // console.log(success);
        },
        err => {
          // console.log(err);
        }
      )
    }
  }
}
</script>

<style scoped>

</style>
