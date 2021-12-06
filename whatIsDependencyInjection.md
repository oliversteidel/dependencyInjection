# Dependency Injection in C#

- ermöglicht, Teile einer App einfach voneinander zu trennen und die verschiedenen Teile der App unabhänging voneinander zu testen, oder auch auszutauschen

- Abhängigkeiten zu konkreten Implementierungen auflösen indem man z.B. mit Interfaces arbeitet

- sorgt dafür, dass die aufrufende Komponente oder Klasse die Abhängigkeiten an die aufgerufene Komponente oder Klasse zur Laufzeit übergibt.

- z.B. eine App die auf unterschiedlichen Plattformen laufen soll, die für bestimmte Systemaufrufe unterschiedliche APIs anbieten.
  - so kann man plattformspezifisches Verhalten wegabstrahieren und sehr viel gemeinsamen Quellcode nutzen. Plattformspezifika werden dann zur Laufzeit via DI eingefügt
