from django.urls import path, re_path

from . import views

urlpatterns = [
    path('', views.index, name="index"),  # localhost:8000/polls
    path('<int:question_id>', views.detail, name="detail"),  # localhost:8000/polls/<1>
    path('<int:question_id>/results', views.results, name="results"),   # localhost:8000/polls/results
    path('<int:question_id>/vote', views.vote, name="vote"),  # localhost:8000/polls/vote
]
